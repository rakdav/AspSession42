using AspSession42.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspSession42.Controllers
{
    [ApiController]
    public class EventController : ControllerBase
    {
        private List<Event> events;
        public EventController()
        {
            events = new List<Event>()
            {
                new Models.Event()
                {
                    Id=1,
                    Title="День открытых дверей",
                    Date=DateTime.Parse("15.03.2025"),
                    Description="Приглашаем всех желающих посетить наше предприятие и познакомиться с процессом производства. В программе экскурсии, мастер-классы и дегустация продукции.",
                    Author="Отдел маркетинга"
                },
                new Models.Event()
                {
                    Id=2,
                    Title="Презентация нового продукта",
                    Date=DateTime.Parse("20.03.2025"),
                    Description="Представляем новый продукт нашей линейки – инновационное решение для автоматизации производственных процессов. Присоединяйтесь к презентации и узнайте все подробности!",
                    Author="Руководство компании"
                },
                new Models.Event()
                {
                    Id=3,
                    Title="Семинар по повышению квалификации сотрудников",
                    Date=DateTime.Parse("26.03.2025"),
                    Description="Проводим семинар для повышения профессиональных навыков наших сотрудников. Программа включает лекции и практические занятия от ведущих экспертов отрасли.",
                    Author="Отдел кадров"
                },
                 new Models.Event()
                {
                    Id=4,
                    Title="Благотворительная акция «Помоги детям»",
                    Date=DateTime.Parse("12.04.2025"),
                    Description="Организуем сбор средств и вещей для поддержки детей из малообеспеченных семей. Все собранные средства будут направлены на покупку школьных принадлежностей и одежды.",
                    Author="Социальный отдел"
                },
                new Models.Event()
                {
                    Id=5,
                    Title="Тренинг по командообразованию",
                    Date=DateTime.Parse("03.04.2025"),
                    Description="Предлагаем сотрудникам принять участие в тренинге по развитию навыков работы в команде. Мероприятие пройдет в формате активного отдыха с элементами тимбилдинга.",
                    Author="Отдел HR"
                }
            };
        }
        [HttpGet]
        [Route("Events")]
        public IQueryable GetEvents()
        {
            var ev = from e in events
                     select e;
            return ev.AsQueryable();
        }
        
    }
}
