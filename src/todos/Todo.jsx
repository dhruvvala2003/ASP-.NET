import * as React from 'react';
import CssBaseline from '@mui/material/CssBaseline';
import Box from '@mui/material/Box';
import Container from '@mui/material/Container';
import Button from '@mui/material/Button';
import InputBase from '@mui/material/InputBase';
import { styled } from '@mui/material';
import Table from '@mui/material/Table';
import TableBody from '@mui/material/TableBody';
import TableCell from '@mui/material/TableCell';
import TableContainer from '@mui/material/TableContainer';
import TableHead from '@mui/material/TableHead';
import TableRow from '@mui/material/TableRow';
import Paper from '@mui/material/Paper';

const Todo = () => {

const [task,setTask]=React.useState([]);
const [inputText,setInputText]=React.useState('');
const ref=React.useRef(null);

const BootstrapInput = styled(InputBase)(({ theme }) => ({
    'label + &': {
      marginTop: theme.spacing(3),
    },
    '& .MuiInputBase-input': {
      borderRadius: 4,
      position: 'relative',
      backgroundColor: theme.palette.background.paper,
      border: '1px solid #ced4da',
      fontSize: 16,
      padding: '10px 26px 10px 12px',
      transition: theme.transitions.create(['border-color', 'box-shadow']),
      // Use the system font instead of the default Roboto font.
      fontFamily: [
        '-apple-system',
        'BlinkMacSystemFont',
        '"Segoe UI"',
        'Roboto',
        '"Helvetica Neue"',
        'Arial',
        'sans-serif',
        '"Apple Color Emoji"',
        '"Segoe UI Emoji"',
        '"Segoe UI Symbol"',
      ].join(','),
      '&:focus': {
        borderRadius: 4,
        borderColor: '#80bdff',
        boxShadow: '0 0 0 0.2rem rgba(0,123,255,.25)',
      },
    },
  }));

  // function createData(name,delete1) {
  //   return { name,delete1 };    
  // }


  


  const handleClick=()=>{

    setTask([...task,inputText])
    ref.current.value=""
    ref.current.focus();
   
  }

  const handleDeleteClick=(row)=>{

    var tmp=task.filter(x=>x!==row);
    setTask(tmp);

  }

  const handleEditClick=(row)=>{
        var custIp=prompt("enter  updated vaule of : "+ row);
        var tmp=task.filter(x=>x!==row);
        setTask(tmp);
        
        setTask([...tmp,custIp]);

  }


  return (
    <div>
    <React.Fragment>
            <CssBaseline />
            <Container maxWidth="sm">
                <div style={{border:"5px solid black"}}>
                <Box sx={{ bgcolor: '#cfe8fc', height: '60vh',width:'60vh' }} >

                    <div>
                        <div >
                            <input ref={ref} type='text' placeholder='enter task...' style={{height:'4vh'}}  onChange={(e)=>setInputText(e.target.value)}  />
                            <Button variant="contained" disableElevation onClick={handleClick}>
                                    Add
                            </Button>
                        </div>

                        <div>

                                            <TableContainer component={Paper}>  
                                            {/* sx={{ minWidth: 650 }} */}
                                            <Table  aria-label="caption table">
                                              <caption>A basic table example with a caption</caption>
                                              <TableHead>
                                                <TableRow>
                                                  <TableCell align="center" >Task</TableCell>
                                                  <TableCell align="center">Delete</TableCell>
                                                  <TableCell align="center">Edit</TableCell>
                                                </TableRow>
                                              </TableHead>
                                              <TableBody>
                                                {task.map((row,idx) => (
                                                  <TableRow key={idx}>
                                                    <TableCell align="center" component="th" scope="row">
                                                      {row}
                                                    </TableCell>
                                                    <TableCell align="center"><button onClick={()=>handleDeleteClick(row)}>Delete</button></TableCell>
                                                    <TableCell align="center"><button onClick={()=>handleEditClick(row)}>Edit</button></TableCell>
                                                    
                                                  </TableRow>
                                                ))}
                                              </TableBody>
                                            </Table>
                                          </TableContainer>

                        </div>
                    </div>
                </Box>
                </div>
            </Container>
    </React.Fragment>

    </div>
  )
}

export default Todo
