﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : Entity
{
    public GameObject tilePrefab;

    public virtual void OnConsume()
    {
        Destroy(this.gameObject);
    }

}
