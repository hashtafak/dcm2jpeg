const start = new Date()
const hrstart = process.hrtime()

const edge = require('edge-js');
const dotNetFunction = edge.func({
    assemblyFile: './x86/Debug/dcm2jpeg.dll',
    typeName: 'Startup',
    methodName: 'Invoke'
});
const path = "demo.dcm"

dotNetFunction(path, function (error, result) {
    console.log(`error: ${error}`)
    
    const end = new Date() - start,
        hrend = process.hrtime(hrstart)

    console.info('Execution time: %dms', end)
    console.info('Execution time (hr): %ds %dms', hrend[0], hrend[1] / 1000000)

    const buffer = Buffer.from(result);
    console.log("Byte length: " + buffer.length);
    console.log("KB: " + buffer.length / 1e+3);
});