using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canaan.Lib
{
    public class MessageBoxUtilities
    {
        /// <summary>
        /// Question
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static DialogResult MessageQuestion(string content)
        {
            return MessageBox.Show(content, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        /// <summary>
        /// Error
        /// </summary>
        /// <param name="ex"></param>
        public static void MessageError(IWin32Window window, Exception ex)
        {
            var error = ReadError(ex);

            error += "\n\n\n";

            if (!string.IsNullOrEmpty(ex.StackTrace))
                error += ex.StackTrace;
               

            MessageBox.Show(window ,error, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        public static void MessageInfo(string info)
        {
            MessageBox.Show(info, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        public static void MessageWarning(string info)
        {
            MessageBox.Show(info, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        private static string ReadError(Exception ex)
        {
            if (ex.InnerException == null)
                return string.Format("{0}\n",ex.Message);

            return ReadError(ex.InnerException);
        }

        public static DialogResult MessageQuestionWarning(string content)
        {
            return MessageBox.Show(content, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}
