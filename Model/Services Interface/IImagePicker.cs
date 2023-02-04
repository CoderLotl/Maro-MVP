using System;
using System.Windows.Forms;

namespace Model
{
	public interface IImagePicker
	{
		void ImagePickerMain(string argType, string arg, Control control);
	}
}
