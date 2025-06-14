// generate-svg-list.js
const fs = require('fs');
const path = require('path');

const baseDir = path.join(__dirname, 'src/assets/media/icons/duotune');
let svgFiles = [];

function walk(dir) {
  fs.readdirSync(dir).forEach(file => {
    const fullPath = path.join(dir, file);
    if (fs.statSync(fullPath).isDirectory()) {
      walk(fullPath);
    } else if (file.endsWith('.svg')) {
      // Store relative path from 'duotune'
      svgFiles.push(path.relative(baseDir, fullPath).replace(/\\/g, '/'));
    } else if (file.endsWith('.png')) {
      // Store relative path from 'duotune'
      svgFiles.push(path.relative(baseDir, fullPath).replace(/\\/g, '/'));
    }
  });
}

walk(baseDir);

fs.writeFileSync(
  path.join(baseDir, 'svg-list.json'),
  JSON.stringify(svgFiles, null, 2)
);

console.log('SVG list generated:', svgFiles.length, 'files');