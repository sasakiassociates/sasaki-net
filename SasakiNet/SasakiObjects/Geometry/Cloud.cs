using Sasaki.Common;
using System;

namespace Sasaki.Geometry;

public class Cloud : ICloud
{

  /// <summary>
  /// 
  /// </summary>
  /// <param name="appId"></param>
  public Cloud(string? appId)
  {
    this.appId = SasakiTools.CheckIfValidId(appId);

  }

  /// <inheritdoc />
  public string appId {get;set;}

  /// <inheritdoc />
  public CloudPoint[] points {get;set;} = Array.Empty<CloudPoint>();
}
