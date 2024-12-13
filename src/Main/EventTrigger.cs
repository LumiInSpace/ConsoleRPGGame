using System.Net.Http.Headers;

namespace ConsoleRPGGame.src.Main
{
    public static class EventTrigger
    {
        public static Event TriggerEvent()
        {
            Random random = new Random();

            return new CommonChestEvent();
           
        }
            
    }
}
