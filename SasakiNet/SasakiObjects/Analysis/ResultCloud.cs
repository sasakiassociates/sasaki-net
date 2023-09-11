using System;
using System.Collections.Generic;
using Sasaki.Common;
using Sasaki.Geometry;

namespace Sasaki.Analysis;

public class ResultCloud : IResultCloud, ISasakiObject
{

  public ResultCloud(string? appId)
  {
    this.appId = SasakiTools.CheckIfValidId(appId);
  }

  public ResultCloud(CloudPoint[] points, List<IResultLayer> layers, string? appId)
  {
    this.points = points;
    this.layers = layers;
    this.appId = SasakiTools.CheckIfValidId(appId);
  }

  /// <inheritdoc />
  public List<IResultLayer> layers {get;set;} = new();
  /// <inheritdoc />
  public string? appId {get;}
  /// <inheritdoc />
  public CloudPoint[] points {get;set;} = Array.Empty<CloudPoint>();
}
