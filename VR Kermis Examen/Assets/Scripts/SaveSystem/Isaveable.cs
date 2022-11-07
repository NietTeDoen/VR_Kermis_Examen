using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Isaveable
{
    object SaveState();

    void LoadState(object state);
}
