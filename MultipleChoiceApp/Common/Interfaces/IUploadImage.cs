using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.Common.Interfaces
{
    public interface IUploadImage
    {
        void onImageUploaded(String tag, String imgUrl);
        void onImageUploading(String tag, int progress);
    }
}
