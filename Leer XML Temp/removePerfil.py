from rembg import remove
from PIL import Image
import os

input_path = os.path.join(os.path.dirname(__file__),'fotoPerfil.png')
output_path = os.path.join(os.path.dirname(__file__),'fotoPerfil_no_bg.png')

input = Image.open(input_path)
output = remove(input)
width, height = output.size
blue_color = (255,255,255)
blue_background = Image.new("RGB", (width, height), blue_color)
blue_background.paste(output, (0,0), output)
blue_background.save(output_path)


