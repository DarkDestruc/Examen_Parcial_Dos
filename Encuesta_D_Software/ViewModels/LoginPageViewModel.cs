using Encuesta_D_Software.Models;
using Encuesta_D_Software.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Encuesta_D_Software.ViewModels
{
    public class LoginPageViewModel: INotifyPropertyChanged
    {
        #region"Propiedades"

        public RegistroUsuarios registroUsuarios { get; set; }
        public Command LoginCommand { get; set; }

        #endregion

        public LoginPageViewModel()
        {
            registroUsuarios = new RegistroUsuarios();
            LoginCommand = new Command(GoToEncuestaPageAsync);

        }

        public event PropertyChangedEventHandler PropertyChanged;

        private async void LoginAsync()
        {
            if (string.IsNullOrEmpty(registroUsuarios.Email) || Util.IsAValidEmail(registroUsuarios.Email.ToLower()))
            {
                await Util.ShowToastAsync("Ingrese Email Registrado");
                return;
            }
            if (string.IsNullOrEmpty(registroUsuarios.Password))
            {
                await Util.ShowToastAsync("Ingrese una Contraseña Valida");
                return;

            }
            Settings.IsAuthenticated = true;
            Settings.Email = registroUsuarios.Email;
            
            await Shell.Current.GoToAsync($"///{nameof(EncuestaPageViewModel)}");
        }

        private async void GoToEncuestaPageAsync()
        {
            await Shell.Current.GoToAsync(nameof(EncuestaPageViewModel));
        }

        private List<KeyValuePair<string, string>> GetLoginData()
        {
            return new List<KeyValuePair<string, string>>
            {
                new("gustavo@gmail.com", "1234.")                 
            };
        }
        public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
