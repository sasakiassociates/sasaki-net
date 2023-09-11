using System.Collections.Generic;
using Sasaki.Common;

namespace Sasaki;

/// <summary>
///   An interface for organizing <typeparamref name="TObject" /> into a singular grouped objects
/// </summary>
/// <typeparam name="TObject"></typeparam>
public interface IStudy<TObject> :
  IHaveName,
  IHaveId
  where TObject : ISasakiObject
{
  /// <summary>
  ///   A list of <typeparamref name="TObject" /> objects to group in a study
  /// </summary>
  public List<TObject> objects {get;set;}
}
