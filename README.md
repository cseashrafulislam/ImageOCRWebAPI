# ImageOCRWebAPI (A Web API that accepts image uploads and returns extracted text using Tesseract OCR.)
Project: Image OCR Web API 
Backend: ASP.NET Core Web API (.NET 8+)
AI Integration:
Tesseract OCR (for open-source text extraction)

# Features
1. Image Upload
Endpoint or UI to upload JPG/PNG images
Save to local folder or blob storage
Extract printed or handwritten text from the image
2. Result Display
Return labels or extracted text to user

Step-by-Step in Postman
1. Open Postman
Click New > HTTP Request or just Create a new request
Set:
Method: POST
URL: http://localhost:5000/api/ocr/upload
2. Go to Body tab
3. Choose form-data
4. Add a field:
5. Key: imageFile 
6. Type: File (click dropdown from "Text")
7. Value: Select an image file (PNG/JPG) that contains some readable text
8. Click Send


