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
    public class FileUpload
    {
        String tag;
        public FileUpload(String tag)
        {
            this.tag = tag;
        }
        async public static Task<String> getDownloadUrl(String refStr)
        {
            String url = await new FirebaseStorage(Constant.firestorageBucket).Child(refStr).GetDownloadUrlAsync();
            return url;
        }
        async public static Task<bool> deleteFile(String filename)
        {
            try
            {
                var task = new FirebaseStorage(Constant.firestorageBucket);
                await task.Child(filename).DeleteAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        async public Task<String[]> upload(String filePath, IUploadImage context, String currentFilename = null)
        {
            //var stream = File.Open(@"C:\YourFile.png", FileMode.Open);
            if (!String.IsNullOrEmpty(currentFilename))
            {
                await deleteFile(currentFilename);
            }
            var stream = File.Open(filePath, FileMode.Open);

            int randomName = Util.getRandom(100000000, 999999999);
            // Construct FirebaseStorage with path to where you want to upload the file and put it there
            String filename = $"{randomName}.png";
            var task = new FirebaseStorage(Constant.firestorageBucket)
             //.Child("data")
             .Child(filename)
             .PutAsync(stream);

            // Track progress of the upload

            task.Progress.ProgressChanged += (s, e) =>
            {
                context.onImageUploading(tag, e.Percentage);
                Util.log($"Progress: {e.Percentage} %");
            };

            // Await the task to wait until upload is completed and get the download url
            String downloadUrl = await task;
            return new String[] { filename, downloadUrl };
        }
    }
}
