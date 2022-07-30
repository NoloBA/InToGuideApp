using System;
using System.Collections.Generic;
using System.Text;

namespace InToGuideApp.Validations
{
    public interface IValidaty
    {
        bool IsValid { get; set; }
        bool IsButtonActive { get; set; }
    }
}
