package UffSoft.WarGame.View;

import JPlay.*;

public class StartMenu {

    public static void main(String[] args) {

        Window janela = new Window(1282,682);
        GameImage fundo = new GameImage("images/start_screen.jpg");
        GameObject jogar = new GameObject();
        GameObject sair = new GameObject();
        Mouse mouse = janela.getMouse();
        Keyboard teclado = janela.getKeyboard();
        boolean exec = true;

        while(exec) {
            fundo.draw();
            janela.update();
          
            jogar.x = 518;
            jogar.y = 376;
            jogar.height = 42;
            jogar.width = 246;
            
            sair.x = 518;
            sair.y = 460;
            sair.height = 42;
            sair.width = 246;
            
            if((mouse.isOverObject(jogar) && mouse.isLeftButtonPressed())) {
                janela.dispose();                
            }
            if(teclado.keyDown(Keyboard.ESCAPE_KEY) || (mouse.isOverObject(sair) && mouse.isLeftButtonPressed()))
                exec = !exec;         
        
        }
        janela.exit();

        
        

        
    }

}
