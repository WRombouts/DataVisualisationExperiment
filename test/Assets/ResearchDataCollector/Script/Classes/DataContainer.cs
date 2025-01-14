﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class DataContainer
{
    public float TimeFromStart { get; set; }
    public int SubjectID { get; set; }
    public string ResearchName { get; set; }
    public List<SerialisableTransform> TransformList { get;set; }
    
}
