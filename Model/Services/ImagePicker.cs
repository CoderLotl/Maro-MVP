using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Maro_MVP;

namespace Model
{
    public class ImagePicker
    {
        public ImagePicker() { }

        public void ImagePickerMain(string argType, string arg, Control control)
        {            
            switch (argType)
            {
                case "Gender":
                    GenderPicker(arg, control);
                    break;
                case "Race":
                    RacePicker(arg, control);
                    break;
                case "Condition":
                    ConditionPicker(arg, control);
                    break;
                case "SpCondition":
                    SpConditionPicker(arg, control);
                    break;
            }
        }

        private void GenderPicker(string arg, Control control)
        {
            Image image = null;

            switch(arg)
            {
                case "Male":
                    image = (Image)Resources.ResourceManager.GetObject("mars");
                    break;
                case "Female":
                    image = (Image)Resources.ResourceManager.GetObject("venus");
                    break;
                case "Unknown":
                    image = (Image)Resources.ResourceManager.GetObject("third_gender");
                    break;
            }
            control.BackgroundImage = image;            
        }

        private void RacePicker(string arg, Control control)
        {
            Image image = null;

            switch(arg)
            {
                case "Folk":
                    image = (Image)Resources.ResourceManager.GetObject("marosia_folk_icon");
                    break;
                case "Avian":
                    image = (Image)Resources.ResourceManager.GetObject("marosia_avian_icon");
                    break;
                case "Therian":
                    image = (Image)Resources.ResourceManager.GetObject("marosia_therian_icon");
                    break;
                case "Golem":
                    image = (Image)Resources.ResourceManager.GetObject("marosia_golem_icon");
                    break;
                case "Daemon":
                    image = (Image)Resources.ResourceManager.GetObject("marosia_daemon_icon");
                    break;
                case "Naga":
                    image = (Image)Resources.ResourceManager.GetObject("marosia_naga_icon");
                    break;
                case "Fae":
                    image = (Image)Resources.ResourceManager.GetObject("marosia_fae_icon");
                    break;
                case "Kobold":
                    image = (Image)Resources.ResourceManager.GetObject("marosia_kobold_icon");
                    break;
                default:
                    image = (Image)Resources.ResourceManager.GetObject("unknown");
                    break;
            }

            control.BackgroundImage = image;

        }

        private void ConditionPicker(string arg, Control control)
        {
            Image conditionImage = null;

            switch (arg)
            {
                case "Normal":
                    conditionImage = (Image)Resources.ResourceManager.GetObject("normal");
                    break;
                case "Sanguine":
                    conditionImage = (Image)Resources.ResourceManager.GetObject("marosia_sanguine_icon");
                    break;
                case "Undead":
                    conditionImage = (Image)Resources.ResourceManager.GetObject("hand");
                    break;
                case "Cursed":
                    conditionImage = (Image)Resources.ResourceManager.GetObject("voodoo_doll");
                    break;
            }

            control.BackgroundImage = conditionImage;
        }

        private void SpConditionPicker(string arg, Control control)
        {
            Image spConditionImage = null;

            switch (arg)
            {
                case "None":
                    spConditionImage = (Image)Resources.ResourceManager.GetObject("person");
                    break;
                case "Avatar":
                    spConditionImage = (Image)Resources.ResourceManager.GetObject("god");
                    break;
            }
            control.BackgroundImage = spConditionImage;
        }
    }
}
