using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace placeholderBug.Controls
{
    public class HEntry : Entry
    {

        public HEntry()
        {
            this.ClearButtonVisibility = ClearButtonVisibility.WhileEditing;
        }

    }
}
