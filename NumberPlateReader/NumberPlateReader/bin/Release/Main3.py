# Main.py

import cv2
import numpy as np
import os
import pytesseract
import DetectChars
import DetectPlates
import PossiblePlate
from PIL import Image
import pymysql
from flask import Flask,request,jsonify
import argparse
import mysql.connector

pytesseract.pytesseract.tesseract_cmd = r"C:\Program Files\Tesseract-OCR\tesseract.exe"

app = Flask(__name__)
# module level variables ##########################################################################

SCALAR_BLACK = (0.0, 0.0, 0.0)
SCALAR_WHITE = (255.0, 255.0, 255.0)
SCALAR_YELLOW = (0.0, 255.0, 255.0)
SCALAR_GREEN = (0.0, 255.0, 0.0)
SCALAR_RED = (0.0, 0.0, 255.0)

showSteps = False
###################################################################################################

@app.route("/")
def fn1():
  
# First create a Github instance: using username and password
#    g = Github("FinalProjectGit", "Github@12")
#   repo = g.get_repo("FinalProjectGit/Project")

#contents = repo.get_contents("Capture.PNG")
#repo.delete_file(contents.path, "remove test", contents.sha)

#    repoClone = pygit2.clone_repository(repo.git_url, 'D:\OpenCV_3_License_Plate_Recognition_Python-master\p')
#    repoClone.remotes.set_url("origin", repo.clone_url)
    
#    from github import Github
#    import pygit2
    
    mydb = mysql.connector.connect(host = "localhost" , user = "root" , passwd = "root" , database = "projectdatabase")
    mycursor = mydb.cursor()
    sql = "INSERT INTO detection (number_plate , offence) VALUES (%s , %s)"

    imageName = request.args.get("imageName")
    print("imageName",imageName)
    
    offences = request.args.get("offenceName")
    print(offences)
    
    blnKNNTrainingSuccessful = DetectChars.loadKNNDataAndTrainKNN()         # attempt KNN training

    if blnKNNTrainingSuccessful == False:                               # if KNN training was not successful
        print("\nerror: KNN traning was not successful\n")  # show error message
        return                                                          # and exit program
    # end if

    imgOriginalScene  = cv2.imread(imageName)               # open image

    if imgOriginalScene is None:                            # if image was not read successfully
        print("\nerror: image not read from file \n\n")  # print error message to std out
        os.system("pause")                                  # pause so user can see error message
        return                                              # and exit program
    # end if

    listOfPossiblePlates = DetectPlates.detectPlatesInScene(imgOriginalScene)           # detect plates

    listOfPossiblePlates = DetectChars.detectCharsInPlates(listOfPossiblePlates)        # detect chars in plates

    cv2.imshow("imgOriginalScene", imgOriginalScene)            # show scene image

    if len(listOfPossiblePlates) == 0:                          # if no plates were found
        print("\nno license plates were detected\n")  # inform user no plates were found
    else:                                                       # else
                # if we get in here list of possible plates has at leat one plate

                # sort the list of possible plates in DESCENDING order (most number of chars to least number of chars)
        listOfPossiblePlates.sort(key = lambda possiblePlate: len(possiblePlate.strChars), reverse = True)

                # suppose the plate with the most recognized chars (the first plate in sorted by string length descending order) is the actual plate
        licPlate = listOfPossiblePlates[0]
        
        cv2.imwrite("D:\OpenCV_3_License_Plate_Recognition_Python-master\p\Capture.PNG", licPlate.imgPlate)

        image = cv2.imread("D:\OpenCV_3_License_Plate_Recognition_Python-master\p\Capture.PNG")
        gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)
        
        gray = cv2.threshold(gray, 0, 255, cv2.THRESH_BINARY | cv2.THRESH_OTSU)[1]
        
        filename = "{}.png".format(os.getpid())
        cv2.imwrite(filename, gray)
        
        from matplotlib import pyplot as plt
        plt.imshow(image)
        plt.show()
        
        text = pytesseract.image_to_string(Image.open(filename))
        os.remove(filename)
        print(text)        
    
        plate=""
        for c in text:
            if c.isupper():
                plate +=c
            elif c.isdigit():
                plate +=c
            elif c.isspace():
                plate +=c
            #end if
        print(plate)
        
        val = (plate , offences)
        mycursor.execute(sql , val)
        mydb.commit()
            
        print("\nNumber Plate Detected\n")  # write license plate text to std out
        print("----------------------------------------")
    #end if
    
    response = jsonify({"Number Plate":plate})
    response.headers.add("Access-Control-Allow-Origin","*")
    return response




#        cv2.imshow("imgPlate", licPlate.imgPlate)           # show crop of plate and threshold of plate
#        cv2.imshow("imgThresh", licPlate.imgThresh)

#        if len(licPlate.strChars) == 0:                     # if no chars were found in the plate
#            print("\nno characters were detected\n\n")  # show message
#            return                                          # and exit program
        # end if
#        if len(listOfPossiblePlates) == 2:
#            licPlate1 = listOfPossiblePlates[1]
#            if len(licPlate1.strChars) == 0:                     # if no chars were found in the plate
#                print("\nno characters were detected in second plate\n\n")  # show message
#                return 
#            else:
#                licPlate.strChars = licPlate.strChars + licPlate1.strChars                                         # and exit program
#        print("numberPlate=",licPlate.strChars)
        # end if else


        
        

#        cv2.imwrite("imgOriginalScene.png", imgOriginalScene)           # write image out to file
        
#        index = repoClone.index
#        index.add('Capture.PNG')
#        index.write()
#        print("kunjan")

#        author = pygit2.Signature("Jay Nankani", "jay.nankani1@gmail.com")
#        commiter = pygit2.Signature("Jay Nankani", "jay.nankani1@gmail.com")
#        tree = index.write_tree()

#        oid = repoClone.create_commit('refs/heads/master', author, commiter, "init commit",tree,[repoClone.head.peel().hex])
#        remote = repoClone.remotes["origin"]
#        credentials = pygit2.UserPass("FinalProjectGit", "Github@12")
#        remote.credentials = credentials
#        callbacks=pygit2.RemoteCallbacks(credentials=credentials)

#        remote.push(['refs/heads/master'],callbacks=callbacks)

       
#        import os
#        os.remove("p\Capture.PNG")

        
#        connection = pymysql.connect(
#                host='localhost',
#                user = 'root',
#                password = 'root',
#                db='project'
#                )
#        cursor1 = connection.cursor()
#        
#        cursor1.execute(
#                
#                ""
#                        )
#        connection.commit()
#        cursor1.close()
#        connection.close()
        
        
        #import pygit

        
#        image = cv2.imread("Capture.png")
#        gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)
#        gray = cv2.threshold(gray, 0, 255, cv2.THRESH_BINARY | cv2.THRESH_OTSU)[1]
#        filename = "{}.png".format(os.getpid())
#        cv2.imwrite(filename, gray)
#        from matplotlib import pyplot as plt
#        plt.imshow(image)
#        plt.show()
#        text = pytesseract.image_to_string(Image.open(filename))
#        os.remove(filename)
#        print(text)
        #file1 = open("Output.txt","a")
        #file1.write(licPlate.strChars)
        #file1.close()"""
    # end if else

    #cv2.waitKey(0)					# hold windows open until user presses a key

    
# end main

###################################################################################################
#
app.run()


















