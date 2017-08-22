using DemoBot.Shared;
using DemoBot.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace DemoBot.Mocks
{
    public static class DialogMock
    {
        public static List<DialogVm> DialogMocks = new List<DialogVm>
        {
            new DialogVm
            {
                Id = 1,
                Trigger = TriggerEnum.TriggerA,
                Questions = new List<QuestionVm>
                {
                    new QuestionVm
                    {
                        Id = 1,
                        FatherId = null,
                        Order = 1,
                        Text = "What's your primary reason for joining"
                    },
                    new QuestionVm
                    {
                        Id = 2,
                        FatherId = 1,
                        Order = 1,
                        Text = "Get stronger"
                    },
                    new QuestionVm
                    {
                        Id = 3,
                        FatherId = 1,
                        Order = 2,
                        Text = "Lose weight"
                    },
                    new QuestionVm
                    {
                        Id = 4,
                        FatherId = 1,
                        Order = 3,
                        Text = "Tone up"
                    },
                    new QuestionVm
                    {
                        Id = 5,
                        FatherId = 2,
                        Order = 1,
                        Text = "Great. Getting stringer makes life easier."
                    },
                    new QuestionVm
                    {
                        Id = 6,
                        FatherId = 3,
                        Order = 1,
                        Text = "We can definitely help lighten things up for you."
                    },
                    new QuestionVm
                    {
                        Id = 7,
                        FatherId = 4,
                        Order = 1,
                        Text = "Excellent. Well-defined goals mean well-defined bodies."
                    }
                }
            },
            new DialogVm
            {
                Id = 2,
                Trigger = TriggerEnum.TriggerB,
                Questions = new List<QuestionVm>
                {
                    new QuestionVm
                    {
                        Id = 1,
                        FatherId = null,
                        Order = 1,
                        Text = "You haven't booked another class yet. Can we help you find one you might like better?"
                    },
                    new QuestionVm
                    {
                        Id = 2,
                        FatherId = 1,
                        Order = 1,
                        Text = "Let's"
                    },
                    new QuestionVm
                    {
                        Id = 3,
                        FatherId = 1,
                        Order = 2,
                        Text = "Maybe later"
                    },
                    new QuestionVm
                    {
                        Id = 4,
                        FatherId = 2,
                        Order = 1,
                        Text = "Fantastic. One moment please."
                    }
                    ,
                    new QuestionVm
                    {
                        Id = 5,
                        FatherId = 3,
                        Order = 1,
                        Text = "Okay. See you soon."
                    }
                }
            }
                    
        };

        public static DialogVm GetDialogVmByTrigger(TriggerEnum trigger)
        {
            return DialogMocks.First(x => x.Trigger == trigger);
        }
    }
}