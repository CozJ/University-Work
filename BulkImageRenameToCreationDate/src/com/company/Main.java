package com.company;

import com.drew.imaging.ImageMetadataReader;
import com.drew.metadata.Metadata;

import java.io.BufferedReader;
import java.io.File;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {

    public static void main(String[] args) throws IOException {
        // sets up reader for console inputs
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        String location;  // location of folder to run batch on
        char confirmation; // confirmation for correct folder
        String imageDate; // date image created
        String image; // original name of image -- May not need
        boolean cont = false;  // boolean to repeat confirmation loop incase of misstype or want to quit

        String[] folderContents; // array of strings to list folder contents
        File f; // Creates a new File instance by converting the given pathname string into an abstract pathname


        while (cont == false)
        {
            System.out.print("Batch Location: ");  ///home/coreysutcliffe/Documents/testbatchfolder/
            location = reader.readLine();
            System.out.println("is" + location + " Correct?");
            System.out.println("Contents:");
            f = new File(location);  //Gives f a destination
            folderContents = f.list();  //Returns an array of strings naming the files and directories in the directory denoted by this abstract pathname.
            getContents(folderContents);
            System.out.println("Y/y = Yes, N/n = No, Q/q to quit:");
            confirmation = reader.readLine().charAt(0);
            if (confirmation == 'Y' || confirmation == 'y'){
                startBatch(f);
                cont = true;
            }
            else if (confirmation == 'N' || confirmation == 'n') {
                cont = false;
            }
            else {
                System.out.println("Quitting Application");
                System.exit(100);
            }
        }
    }

    private static void getContents(String[] folderContents) {
        if (folderContents == null){
            System.out.println("Empty/Invalid Location");
            return;
        }

        for (String folderContent : folderContents) {
            System.out.println(folderContent);
        }
        return;
    }

    private static void startBatch(File f)
    {
        File[] ListOfFiles = f.listFiles();
        String SourcePath = f.getAbsolutePath();

        for (int i = 0; i < ListOfFiles.length; i++) {
            if(ListOfFiles[i].isFile()) {
                File rename = new File(SourcePath +"/"+ ListOfFiles[i].getName());
                rename.renameTo(new File(SourcePath + "/"+i+".jpg"));
            }
        }
        System.out.println("Processed Image");
    }

    /*private static String getDate(File f)
    {
        Metadata metadata = ImageMetadataReader.readMetadata(f);
        String FileCreationDate;
        return "";
    }*/
}