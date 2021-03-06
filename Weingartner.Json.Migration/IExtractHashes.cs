﻿namespace Weingartner.Json.Migration
{
    public interface IUpdateVersions<in T>
    {
        int GetVersion(T data);

        void SetVersion(T data, int version);
    }
}
