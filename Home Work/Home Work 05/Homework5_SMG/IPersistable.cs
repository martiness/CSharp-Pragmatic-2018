using System;

namespace Homework5
{
    public interface IPersistable
    {

        void Save(string fileName);

        void Load(string fileName);

    }
}