using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using DemoBot.Shared;
using DemoBot.Mocks;
using System.Linq;

namespace DemoBot.Dialogs
{
    [Serializable]
    public class RootDialog : IDialog<object>
    {
        public Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);

            return Task.CompletedTask;
        }

        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
        {
            var activity = await result as Activity;
            
            //Create a Reply message
            var reply = context.MakeMessage();
            Enum.TryParse(activity.Text, true, out TriggerEnum trigger);

            //Check if trigger is defined
            if (Enum.IsDefined(typeof(TriggerEnum), trigger))
            {
                //Get Entire dialog for given trigger
                var entireDialog = DialogMock.GetDialogVmByTrigger(trigger);
                reply.Text = entireDialog.Questions.OrderBy(x => x.Order).First().Text;
                reply.Locale = "en-Us";
                reply.ChannelData = entireDialog;

                await context.PostAsync(reply);
            }
            else
            {
                await context.PostAsync("Not a Trigger");
            }
            
            context.Wait(MessageReceivedAsync);
        }
    }
}