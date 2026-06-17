using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorNotaDeDebito.Utils
{
    public static class Utils
    {
        public static void ValidateTelMask(MaskedTextBox masked)
        {
            if (masked is null) return;
            if (masked.Text.Length == 14) masked.Mask = "(00) 0000-0000";
            else if (masked.Text.Length == 15) masked.Mask = "(00) 90000-0000";
        }

        public static void SetDefaultMask(MaskedTextBox masked)
        {
            masked.Mask = "(00) 90000-0000";
        }
    }
}
