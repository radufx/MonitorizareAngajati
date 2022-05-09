using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorizareAngajati.model
{
    [Serializable]
    public class Entity
    {
        protected int key;

        public int getKey()
        {
            return key;
        }
        public void setKey(int key)
        {
            this.key = key;
        }

        public override bool Equals(Object o)
        {
            if (this == o)
            {
                return true;
            }
            if (!(o.GetType() == typeof(Entity))) {
                return false;
            }
            Entity entity = (Entity) o;
            return getKey().Equals(entity.getKey());
        }

        public override int GetHashCode()
        {
            return 249886028 + key.GetHashCode();
        }

        public override String ToString()
        {
            return "Entity{" + "key=" + key + "}";
        }

    }
}
