using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{
    class EntityManager
    {
        private Dictionary<int, BaseGameEntity> entityMap = new Dictionary<int, BaseGameEntity>();
        private static EntityManager instance = new EntityManager();

        public static EntityManager GetInstance()
        {
            return instance;
        }

        public void AddEntity(int id,BaseGameEntity entity)
        {
            if (!entityMap.ContainsKey(id))
            {
                entityMap.Add(id, entity);
            }
        }

        public void RemoveEntity(int id)
        {
            if (entityMap.ContainsKey(id))
            {
                entityMap.Remove(id);
            }
        }

        public BaseGameEntity GetEntity(int id)
        {
            if (!entityMap.ContainsKey(id))
            {
                return null;
            }
            return entityMap[id];
        }

        public Dictionary<int, BaseGameEntity> GetEntityMap()
        {
            return entityMap;
        }
    }
}
