﻿using CoLocatedCardSystem.CollaborationWindow.DocumentModule;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Input;
using Windows.UI.Xaml.Input;

namespace CoLocatedCardSystem.CollaborationWindow.InteractionModule
{
    public class SemanticCard:Card
    {
        User owner = User.ALEX;
        LayerBase[] layers;
        int currentLayer;
        Document document;
        private const int LAYER_NUMBER= 4;

        public User Owner
        {
            get
            {
                return owner;
            }

            set
            {
                owner = value;
            }
        }

        public Document Document
        {
            get
            {
                return document;
            }

            set
            {
                document = value;
            }
        }

        public SemanticCard(CardController cardController) : base(cardController)
        {
        }

        /// <summary>
        /// Initialize a semantic card.
        /// </summary>
        /// <param name="cardID"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="position"></param>
        /// <param name="scale"></param>
        /// <param name="rotation"></param>
        internal override void Init(string cardID, User user)
        {
            base.Init(cardID, user);
            this.owner = user;
            layers = new LayerBase[LAYER_NUMBER];
            layers[0] = new Layer1(this);
            layers[1] = new Layer2(this);
            layers[2] = new Layer3(this);
            layers[3] = new Layer4(this);
            foreach (var layer in layers) {
                layer.Init();
            }
            this.Children.Add(layers[0]);
        }
        /// <summary>
        /// Load the document to the card. Set the content to all the layers.
        /// </summary>
        /// <param name="document"></param>
        internal async Task LoadDocument(Document document) {
            this.document = document;
            foreach (var layer in layers)
            {
                await layer.SetArticle(this.document);
            }
        }
    }
}
