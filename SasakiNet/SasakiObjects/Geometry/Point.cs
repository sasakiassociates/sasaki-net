using Sasaki.Common;
using System.Numerics;

namespace Sasaki.Geometry;

public class Point : SasakiObject
{
  /// <summary>
  /// 
  /// </summary>
  public Vector3 position = Vector3.Zero;

  /// <summary>
  /// 
  /// </summary>
  public Vector3 vector = Vector3.Zero;

  /// <summary>
  /// some additional info
  /// </summary>
  public string meta = "";

}
