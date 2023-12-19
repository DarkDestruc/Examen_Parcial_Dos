using Encuesta_D_Software.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encuesta_D_Software.Services.Interfaces
{
    public interface IQuestionRegister
    {
        public Task<bool> RegistroRespuestasAsync(RegisterQuestions registerQuestions);
    }
}
