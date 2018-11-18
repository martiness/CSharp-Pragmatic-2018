using System;

namespace CarGarage
{
    public class Car
    {
        public Engine Engine
        {
            get => default(Engine);
            set
            {
            }
        }

        public void ChangeOil()
        {
            // throws runtime exception if the cast is invalid 
            // var specificEngineUnsafeCast = (InternalCombustionEngine)Engine;

            // returns NULL if the cast is invalid
            var specificEngineSafeCast = Engine as InternalCombustionEngine;

            if (specificEngineSafeCast != null)
            {
                specificEngineSafeCast.ChangeOil();
            }

            // another way to safely cast
            //if (Engine is InternalCombustionEngine)
            //{
            //    ((InternalCombustionEngine)Engine).ChangeOil();
            //}
        }

        public void ChangeTires()
        {
            throw new System.NotImplementedException();
        }
    }
}