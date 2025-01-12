using DevExpress.CodeParser;
using DevExpress.Diagram.Core.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.CodeParser.CodeStyle.Formatting.Rules.Spacing.Parentheses;
using static System.Net.Mime.MediaTypeNames;

namespace Ticari_Otomasyon
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //For desktop applications, add the following line of code to run before any spatial operations are performed:

            //SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new login());
        }
    }
}
