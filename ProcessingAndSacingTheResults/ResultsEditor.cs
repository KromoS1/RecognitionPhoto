using System.Collections.Generic;
using Vintasoft.Imaging.Ocr;
using Vintasoft.Imaging.Ocr.Results;

namespace ProcessingAndSavingTheResults
{
    public class ResultsEditor : IResultsEditor
    {
        private readonly ISaveResult _saveResult;

        public ResultsEditor(ISaveResult saveResult)
        {
            _saveResult = saveResult;
        }

        private const float MIN_CONFIDENCE = 75.0f;
        private List<OcrObject> removeObject = new List<OcrObject>();

        public void EditorResult(OcrPage ocrResult)
        {
            OcrObject[] ocrObjects = ocrResult.GetObjects(OcrObjectType.Word);

            foreach (var word in ocrObjects)
            {
                if (word.Confidence< MIN_CONFIDENCE)
                {
                    removeObject.Add(word);
                }
            }

            OcrResultsEditor editor = new OcrResultsEditor(ocrResult);
            editor.RemoveObjects(removeObject.ToArray());
            editor.ValidateResults();
            _saveResult.Save(ocrResult);
        }
    }
}
