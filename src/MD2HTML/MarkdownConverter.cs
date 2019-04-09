﻿using System;
using MarkdownSharp;

namespace MD2HTML
{
    public class MarkdownConverter : IMarkdownConverter
    {
        private readonly Markdown _markdown;

        public MarkdownConverter(Markdown markdown)
        {
            if(markdown == null)
                throw new ArgumentNullException("markdown");
            _markdown = markdown;
        }

        public Markdown Options
        {
            get { return _markdown; }
        }

        public string Version
        {
            get { return _markdown.Version; }
        }

        public string Transform(string text)
        {
            return _markdown.Transform(text);
        }
    }
}