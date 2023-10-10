/** @type {import('tailwindcss').Config} */

const defaultTheme = require('tailwindcss/defaultTheme')

module.exports = {
    content: [
        "./Pages/**/*.{razor,cshtml}",
        "./*.razor",
        "./Shared/**/*.razor"
    ],
  theme: {
      extend: {
          fontFamily: {
              'default': ['Inter', 'Helvetica', 'Arial', 'sans-serif'],
              'display': ['Josefin Sans', 'Helvetica', 'Arial', 'sans-serif']
          },
          minWidth: {
              '1/4': "25%",
              ...defaultTheme.spacing
          },
          maxWidth: {
              ...defaultTheme.spacing
          }
        },
  },
  plugins: [],
}

