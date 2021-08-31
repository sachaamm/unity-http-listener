using System;
using System.Collections.Generic;
using System.Linq;
using Scripts.Service;
using UnityCustomHttpListener.Demo.Controller;
using UnityCustomHttpListener.Demo.Model;
using UnityCustomHttpListener.Scripts.Router;
using UnityEngine;

namespace UnityCustomHttpListener.Demo.DataInjector
{
    public class GameObjectsCountDataInjector : MonoBehaviour
    {

        void Update()
        {
            InjectData();
        }
        
        void InjectData()
        {
            GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>() ;
            List<object> list = allObjects.Select(go => ConvertGameObjectToModel(go) as object).ToList();
            UnityHttpListener.SetValueInObjectMap(ExampleController.ObjectsMapExampleGameObjectsListKey, list);
        }

        public GameObjectInScene ConvertGameObjectToModel(GameObject go)
        {
            GameObjectInScene gameObjectInScene = new GameObjectInScene();
            gameObjectInScene.Name = go.name;
            var position = go.transform.position;
            gameObjectInScene.Xpos = position.x;
            gameObjectInScene.Ypos = position.y;
            gameObjectInScene.Zpos = position.z;
            return gameObjectInScene;
        }
    }
}