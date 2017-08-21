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
                        Text = "First Question Text for Trigger A"
                    },
                    new QuestionVm
                    {
                        Id = 2,
                        FatherId = 1,
                        Order = 1,
                        Text = "First Option Text for Question 1"
                    },
                    new QuestionVm
                    {
                        Id = 3,
                        FatherId = 1,
                        Order = 2,
                        Text = "Second Option Text for Question 1"
                    },
                    new QuestionVm
                    {
                        Id = 4,
                        FatherId = null,
                        Order = 2,
                        Text = "Second Question Text for Trigger A"
                    },
                    new QuestionVm
                    {
                        Id = 5,
                        FatherId = null,
                        Order = 3,
                        Text = "Third Question Text for Trigger A"
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
                        Text = "First Question Text for Trigger B"
                    },
                    new QuestionVm
                    {
                        Id = 2,
                        FatherId = null,
                        Order = 2,
                        Text = "Second Question Text for Trigger B"
                    },
                    new QuestionVm
                    {
                        Id = 3,
                        FatherId = null,
                        Order = 3,
                        Text = "Third Question Text for Trigger B"
                    },
                    new QuestionVm
                    {
                        Id = 4,
                        FatherId = 3,
                        Order = 1,
                        Text = "First Option Text for Question 3"
                    },
                    new QuestionVm
                    {
                        Id = 5,
                        FatherId = 3,
                        Order = 2,
                        Text = "Second Option Text for Question 3"
                    },
                }
            }
                    
        };

        public static DialogVm GetDialogVmByTrigger(TriggerEnum trigger)
        {
            return DialogMocks.First(x => x.Trigger == trigger);
        }
    }
}