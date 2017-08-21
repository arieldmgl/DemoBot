using DemoBot.Shared;
using System.Collections.Generic;

namespace DemoBot.ViewModels
{
    public class DialogVm
    {
        public int Id { get; set; }

        public TriggerEnum Trigger { get; set; }

        public List<QuestionVm> Questions { get; set; }
    }
}