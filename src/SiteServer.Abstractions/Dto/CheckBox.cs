﻿using System;
using Datory;

namespace SiteServer.Abstractions.Dto
{
    public class CheckBox<T>
    {
        public CheckBox(T label, string text)
        {
            Label = label;
            Text = text;
        }

        public CheckBox(Enum e)
        {
            Label = TranslateUtils.Get<T>(e.GetValue());
            Text = e.GetDisplayName();
        }

        public T Label { get; set; }
        public string Text { get; set; }
    }
}