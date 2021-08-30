using System;
using System.Collections.Generic;

namespace UnityCustomHttpListener.Demo.Model
{
    [Serializable]
    public class GameObjectsCountResult
    {
        public List<GameObjectInScene> GameObjectInScenes;
    }

    [Serializable]
    public class GameObjectInScene
    {
        public string Name;
        public float Xpos;
        public float Ypos;
        public float Zpos;
    }
}