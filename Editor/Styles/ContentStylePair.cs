using System;
using UnityEngine;

namespace Sourav.ReferenceFinder
{
    [Serializable]
    internal class ContentStylePair
    {
        public GUIContent Content = new GUIContent();
        public GUIStyle Style = new GUIStyle();
    }
}