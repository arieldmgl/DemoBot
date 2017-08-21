using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;

namespace DemoBot.Controllers
{
    [BotAuthentication]
    public class MessagesController : ApiController
    {
        /// <summary>
        /// POST: api/Messages
        /// Receive a message from a user and reply to it
        /// </summary>
        public async Task<HttpResponseMessage> Post([FromBody]Activity activity)
        {
            if (activity.Type == ActivityTypes.Message)
            {
                await Conversation.SendAsync(activity, () => new Dialogs.RootDialog());
            }
            else if (activity.Type == ActivityTypes.ConversationUpdate)
            {
                IConversationUpdateActivity update = activity;
                var client = new ConnectorClient(new Uri(activity.ServiceUrl), new MicrosoftAppCredentials());
                if (activity.MembersAdded != null && activity.MembersAdded.Any())
                {
                    foreach (var newMember in update.MembersAdded)
                    {
                        if (newMember.Id != update.Recipient.Id)
                        {
                            var reply = activity.CreateReply();
                            reply.Text = "Welcome, posible dialog triggers are \"1\" and \"2\"";
                            await client.Conversations.ReplyToActivityAsync(reply);
                        }
                    }
                }
            }
            var response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }
    }
}