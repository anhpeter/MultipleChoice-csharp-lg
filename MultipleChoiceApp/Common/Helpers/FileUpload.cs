using Firebase.Storage;
using MultipleChoiceApp.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceApp.Common.Helpers
{
    class FileUpload
    {
        String tag;
        public FileUpload(String tag)
        {
            this.tag = tag;
        }
        async public Task<String> upload(String folder, String filePath, IUploadImage context)
        {
            //var stream = File.Open(@"C:\YourFile.png", FileMode.Open);
            var stream = File.Open(filePath, FileMode.Open);

            int randomName = Util.getRandom(100000000, 999999999);
            // Construct FirebaseStorage with path to where you want to upload the file and put it there
            var task = new FirebaseStorage(Constant.firestorageBucket)
             //.Child("data")
             .Child(folder)
             .Child($"{randomName}.png")
             .PutAsync(stream);

            // Track progress of the upload

            task.Progress.ProgressChanged += (s, e) =>
            {
                context.onImageUploading(tag, e.Percentage);
                Util.log($"Progress: {e.Percentage} %");
            };

            // Await the task to wait until upload is completed and get the download url
            var downloadUrl = await task;
            return downloadUrl;
        }
    }
}
