import './App.css'  
import Login from './jwtBackChodi/Login';
import Todo from './todos/Todo';
// import AuthDash from './hocfolder/Dashbord';
import Ext1 from './userefimplementation/Ext1';
  
import FormSubmition from './formInReact/FormSubmition';



import Hoc from './Design Pattern/hoc/Hoc';
import Props_Passing from './Design Pattern/renderprops/Props_Passing';
import ReactMd from './react md/ReactMd';
import Tabs from './Design Pattern/Composition/Tabs';
import Compo1 from './Design Pattern/Composition/Compo1';


function App() {  
    return (  
        <>  
            {/* below for  hoc     */}
                  {/* <AuthDash />    */}

                {/* below fo r useref   */}
                {/* <Ext1/> */}
                {/* <Todo/> */}
                {/* <Login/> */}
                
                {/* <FormSubmition/> */}




                {/* design pattern........... */}
                {/* <Props_Passing/> */}
         
                {/* <Hoc/> */}
                <Compo1/>


            {/* reACT MARK DOWN !!!! */}
                {/* <ReactMd/> */}

        </>  
    );  
}  

export default App;  