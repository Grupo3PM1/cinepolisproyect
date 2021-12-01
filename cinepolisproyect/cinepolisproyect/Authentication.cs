using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cinepolisproyect
{
    public interface Authentication
    {
        Task<string> LoginWithEmailAndPassword(string email, string password);
        Task<string> SignUpWithEmailAndPassword(string email, string password);
        Task ResetPassword(string email);

        bool SignOut();

        bool IsSignIn();
    }
}
