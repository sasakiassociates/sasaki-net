using System;
using System.Collections.Generic;
using Sasaki.Common;
using Sasaki.Geometry;

namespace Sasaki.Analysis;

/// <summary>
/// A basic result cloud object
/// </summary>
public class ResultCloud : SasakiObject, IResultCloud<IResultLayer>
{
  /// <inheritdoc />
  public List<IResultLayer> layers {get;set;} = new();

  /// <inheritdoc />
  public CloudPoint[] points {get;set;} = Array.Empty<CloudPoint>();
}
