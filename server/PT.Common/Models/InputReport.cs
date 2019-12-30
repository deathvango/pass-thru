﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PT.Common
{
  public class InputReport
  {
    public long MessageTimestamp { get; set; }
    public ulong Buttons { get; set; }
    public Axis Axis1 { get; set; }
    public Axis Axis2 { get; set; }
    public float Throttle { get; set; }
    public float Brake { get; set; }
  }

  public class Axis
  {
    public float X { get; set; }
    public float Y { get; set; }
    public float Z { get; set; }
  }
}
