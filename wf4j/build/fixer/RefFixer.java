import java.io.*;
import java.nio.CharBuffer;

/**
 * Created by Daniel Leping.
 * Date: Feb 12, 2010
 * Time: 8:03:37 AM
 */
public class RefFixer {
    public static void main(String[] args) throws Exception {
        System.err.println("This is a temporary tool for fixing ref in C# generated classes.\nShould be removed just after fix in jni4net proxygen.");

        if(args.length % 3 != 0) {
            System.err.println("Usage: file string replace");
            System.exit(0);
        }

        for(int i = 0; i < args.length; i += 3) {
            String filename = args[i];
            String toFind = args[i+1];
            String toReplace = args[i+2];
            File file = new File(filename);
            if(file.exists() && !file.isDirectory() && file.isFile()) {
                FileReader reader = new FileReader(file);
                CharBuffer cb = CharBuffer.allocate((int)file.length());
                reader.read(cb);
                reader.close();
                cb.flip();
                StringBuffer sb = new StringBuffer(cb);
                int start = sb.indexOf(toFind);
                if(start < 0) {
                    throw new Exception("Unable to find \"" + toFind + "\" in file: " + filename);
                }
                while (start > 0) {
                    sb.delete(start, start + toFind.length());
                    sb.insert(start, toReplace);
                    start = sb.indexOf(toFind, start + toReplace.length());
                }
                FileWriter writer = new FileWriter(file, false);
                writer.write(sb.toString());
                writer.close();
            }
        }
    }
}
