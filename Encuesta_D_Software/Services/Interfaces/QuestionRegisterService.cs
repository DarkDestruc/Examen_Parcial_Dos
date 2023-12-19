using Encuesta_D_Software.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuesta_D_Software.Services.Interfaces
{
    public class QuestionRegisterService: IQuestionRegister
    {
        public async Task<bool> RegistroRespuestasAsync(RegisterQuestions registersQuestions)
        { 
            await Task.Delay(1000);
            if (registersQuestions == null ||
                string.IsNullOrWhiteSpace(registersQuestions.Reg1) ||
                registersQuestions.Reg2 == 0 ||
                string.IsNullOrWhiteSpace(registersQuestions.Reg3))
            {
                return false;
            }

            return true;
        }

    }
}
