﻿using CoLocatedCardSystem.CollaborationWindow.DocumentModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoLocatedCardSystem.CollaborationWindow.InteractionModule
{
    class Layer4:LayerBase
    {
        public Layer4(Card card) : base(card)
        {
        }

        internal override async Task SetArticle(Document doc)
        {
            await base.SetArticle(doc);
        }
    }
}
