using AspSession42.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace AspSession42.Controllers
{
    [ApiController]
    public class NewsController : ControllerBase
    {
        private List<New> news;
        
        public NewsController()
        {
            news = new List<New>()
            {
                new New()
                {
                    Title="Следы динозавра",
                    Date=DateTime.Parse("08.02.2025"),
                    Description="В монгольской пустыне Гоби палеонтологи" +
                    " обнаружили гигантские следы динозавра, сравнимые по размеру с автобусом. " +
                    "Во время раскопок был обнаружен отпечаток размером 92 сантиметра.",
                    Image="images/dino.jpeg"
                },
                new New()
                {
                    Title="Финал Чемпионата «Профессионалы» завершился в Санкт-Петербурге",
                    Date=DateTime.Parse("30.11.2025"),
                    Description="В Санкт-Петербурге подвели итоги Финала " +
                    "Чемпионата по профессиональному мастерству «Профессионалы». " +
                    "Торжественная церемония закрытия Чемпионата и награждения " +
                    "победителей прошла во дворце спорта «СКА Арена». Организаторы " +
                    "Финала – Минпросвещения России, Правительство Санкт-Петербурга. " +
                    "Федеральный оператор – Институт развития профессионального образ" +
                    "ования. Мероприятия проходят при поддержке Правительства Российской " +
                    "Федерации.",
                    Image="images/prof.jpeg"
                },
                new New()
                {
                    Title="Медали «80 лет Победы»",
                    Date=DateTime.Parse("27.01.2025"),
                    Description="Юбилейные медали \"80 лет Победы в Великой Отечественной" +
                    " войне 1941-1945 годов\" получат все вете" +
                    "раны Великой Отечественной войны, заявил президент " +
                    "РФ Владимир Путин.",
                    Image="images/victory.jpeg"
                }
            };
        }
        [HttpGet]
        [Route("News")]
        [Produces("application/xml")]
        public List<New> GetNews()
        {
            var ev = from e in news
                     select e;
            return ev.ToList();
        }

    }
}
