using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace GameBase2022
{
    internal static class EntityManager
    {

        static int entityNumber;

        static Entity firstEntity;
        static Entity lastEntity;
        
        static internal void Initialize()
        {
            entityNumber = 0;
            firstEntity = null;
            lastEntity = null;
        }

        static internal void Update(GameTime gameTime)
        {

            Entity stepEntity = firstEntity;

            while (stepEntity != null)
            {
                if(stepEntity.isActive)
                {
                    stepEntity.Update(gameTime);

                }
                stepEntity = stepEntity.nextEntity;
            }


        }

        static internal void Draw(GameTime gameTime)
        {
            Entity stepEntity = firstEntity;

            while (stepEntity != null)
            {
                if (stepEntity.isActive)
                {
                    stepEntity.Draw(gameTime);

                }
                stepEntity = stepEntity.nextEntity;
            }
        }

        internal static void AddEntity(Entity entityToAdd)
        {
            entityToAdd.uniqueId = entityNumber++;
            
            if(firstEntity == null)
            {
                firstEntity = entityToAdd;
            }
            else
            {
                lastEntity.nextEntity = entityToAdd;
            }
            
            lastEntity = entityToAdd;

        }

        internal static void RemoveEntityWithId(int uniqueId)
        {
            Entity stepEntity = firstEntity;
            if(firstEntity.uniqueId == uniqueId)
            {
                firstEntity = firstEntity.nextEntity;
            }
            while(stepEntity.nextEntity != null)
            {
                if(stepEntity.nextEntity.uniqueId == uniqueId)
                {
                    stepEntity.nextEntity = stepEntity.nextEntity.nextEntity;
                }
                stepEntity = stepEntity.nextEntity;
            }
        }

        // En remove som tar bort en array av entities.. array av int och id..???
        internal static void RemoveArrayOfEntititesWithId(int[] uniqueId)
        {
            for (int i = 0; i < uniqueId.Length; i++)
            {
                RemoveEntityWithId(uniqueId[i]);
            }
        }
    }
}
