using InterfaceCli.APIGreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterfaceCli.Models
{
    public class Questions
    {

        public IList<SPI_QuestionAnswer_Result> ObtainQuestionBase()
        {
            IList<SPI_QuestionAnswer_Result> ListQuestion = null;
            using (APIGreen.Service1Client api = new APIGreen.Service1Client())
            {
                {
                    ListQuestion = api.GetQuestionAnswer();
                }
            }
            return ListQuestion;
        }
    }
}