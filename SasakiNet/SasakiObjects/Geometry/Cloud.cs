using Sasaki.Common;
using System;

namespace Sasaki.Geometry;

/// <summary>
/// The basic cloud object  
/// </summary>
public class Cloud : SasakiObject, ICloud
{

  /// <inheritdoc />
  public CloudPoint[] points {get;set;} = Array.Empty<CloudPoint>();


}

[Serializable]
public struct CloudPoint
{

  public double x, y, z, xn, yn, zn;

  public CloudPoint(double x, double y, double z, double xn = 0, double yn = 0, double zn = 0)
  {
    this.x = x;
    this.y = y;
    this.z = z;
    this.xn = xn;
    this.yn = yn;
    this.zn = zn;
  }
}
