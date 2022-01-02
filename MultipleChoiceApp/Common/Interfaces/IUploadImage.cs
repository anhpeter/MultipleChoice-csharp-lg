using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.Common.Interfaces
{
    public interface IUploadImage
    {
        void onImageUploaded(String tag, String filename, String url);
        void onImageDeleted(String tag);
        void onImageUploading(String tag, int percent);
    }
}
