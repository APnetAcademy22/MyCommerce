﻿namespace DBLibrary.Persisters
{
    public interface Persister<T>
    {
        void Persist(T objToPersist);
    }
}
