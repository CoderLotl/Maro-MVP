using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Controls;

namespace Views
{
    public class ProgressBarFiller
    {

        public void FillProgressBar(XpProgressBar control, string text, int number)
        {
            string level = "";
            int maximum = 0;


            if (number <= 99)
            {
                if (text == "Strength" || text == "Dexterity" || text == "Knowledge")
                {
                    level = "Weak";
                }
                else
                {
                    level = "Poor";
                }
                maximum = 0;
            }
            else if (number <= 199)
            {
                if (text == "Strength" || text == "Dexterity" || text == "Knowledge")
                {
                    level = "Okay";
                }
                else
                {
                    level = "Novice";
                }
                maximum = 100;
            }
            else if (number <= 299)
            {
                if (text == "Strength" || text == "Dexterity" || text == "Knowledge")
                {
                    level = "Average";
                }
                else
                {
                    level = "Apprentice";
                }
                maximum = 200;
            }
            else if (number <= 399)
            {
                if (text == "Strength" || text == "Dexterity" || text == "Knowledge")
                {
                    level = "Good";
                }
                else
                {
                    level = "Expert";
                }
                maximum = 300;
            }
            else
            {
                if (text == "Strength" || text == "Dexterity" || text == "Knowledge")
                {
                    level = "Strong";
                }
                else
                {
                    level = "Master";
                }
                maximum = 400;
            }

            control.Text = text + ": " + level;
            control.Position = number - maximum;
        }
    }
}
