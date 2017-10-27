using UnityEngine;
using System.Collections;

public interface IGameFrameworkComponent
{
    void OnAwake();

    void OnStart();

    void OnShutDown();
}
