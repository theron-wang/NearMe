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
              '1/2': "50%",
              ...defaultTheme.spacing
          },
          minHeight: {
              ...defaultTheme.spacing
          },
          maxWidth: {
              '1/2': "50%",
              '3/4': "75%",
              ...defaultTheme.spacing
          },
          maxHeight: {
              '3/4': "75%"
          },
          animation: {
              'enlarge': 'enlarge 0.2s cubic-bezier(0.42, 0, 0.63, 1.77) forwards',
              'enlarge-small': 'enlarge-small 0.2s cubic-bezier(0.42, 0, 0.63, 1.77) forwards'
          },
          keyframes: {
              enlarge: {
                  '0%': { '--tw-scale-x': '.97', '--tw-scale-y': '.97' },
                  '50%': { '--tw-scale-x': '1.03', '--tw-scale-y': '1.03' },
                  '100%': { '--tw-scale-x': '1', '--tw-scale-y': '1' }
              },
              'enlarge-small': {
                  '0%': { '--tw-scale-x': '.99', '--tw-scale-y': '.99' },
                  '50%': { '--tw-scale-x': '1.01', '--tw-scale-y': '1.01' },
                  '100%': { '--tw-scale-x': '1', '--tw-scale-y': '1' }
              }
          }
        },
  },
  plugins: [],
}

